using Colonies.DataAccess;
using Colonies.Servicesa;
using System;
using System.Windows.Forms;

namespace Colonies
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var dBcon = DBcon.Instance; // Inicializa la conexión de la base de datos
                var houseDAO = new HouseDAO(dBcon.GetConnection()); // Usa la conexión
                var houseService = new HouseService(houseDAO);

                // Inicializa e inicia el formulario principal
                Application.Run(new Form1(houseService));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



/*// Ejemplo de agregar una nueva casa
                var newHouse = new HouseDTO
                {
                    hous_name = "Sunny Villa",
                    hous_postalAddress = "123 Sunshine Blvd",
                    hous_postalCode = 12345,
                    hous_nameStreet = "Sunshine Blvd",
                    hous_capacity = 5,
                    regi_id = 1
                };
houseService.AddHouse(newHouse);
Console.WriteLine("House added successfully.");

// Ejemplo de obtener una casa
var retrievedHouse = houseService.GetHouse(newHouse.hous_id);
if (retrievedHouse != null)
{
    Console.WriteLine($"House: {retrievedHouse.hous_name}, Address: {retrievedHouse.hous_postalAddress}");

    // Ejemplo de actualizar una casa
    retrievedHouse.hous_postalAddress = "456 New Address";
    houseService.UpdateHouse(retrievedHouse);
    Console.WriteLine("House updated successfully.");

    // Ejemplo de eliminar una casa
    houseService.DeleteHouse(retrievedHouse.hous_id);
    Console.WriteLine("House deleted successfully.");
}
*/