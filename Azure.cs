using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class Azure
    {
        public Azure()
        {
        }
        public string SubirFoto(string foto)
        {
            string cadenaConexion = "DefaultEndpointsProtocol=https;AccountName=trivialjuan;AccountKey=YYc+i4phslepOltC/RKHpuC4XljLcoqhd6PGVJQF0zj8hUBtAeItv3hhiJaruws/emXHUlcSF/3T+AStBxtOvg==;EndpointSuffix=core.windows.net"; //La obtenemos en el portal de Azure, asociada a la cuenta de almacenamiento
            string nombreContenedorBlobs = "trivial"; //El nombre que le hayamos dado a nuestro contenedor de blobs en el portal de Azure
            string rutaImagen = foto;

            //Obtenemos el cliente del contenedor
            var clienteBlobService = new BlobServiceClient(cadenaConexion);
            var clienteContenedor = clienteBlobService.GetBlobContainerClient(nombreContenedorBlobs);

            //Leemos la imagen y la subimos al contenedor
            Stream streamImagen = File.OpenRead(rutaImagen);
            string nombreImagen = Path.GetFileName(rutaImagen);
            clienteContenedor.UploadBlob(nombreImagen, streamImagen);

            //Una vez subida, obtenemos la URL para referenciarla
            var clienteBlobImagen = clienteContenedor.GetBlobClient(nombreImagen);
            string urlImagen = clienteBlobImagen.Uri.AbsoluteUri;
            return urlImagen;
        }
    }
}
