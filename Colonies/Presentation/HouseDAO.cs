using Colonies.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Colonies.DataAccess
{
    public class HouseDAO : InterfazHouseDAO
    {
        private readonly MySqlConnection _connection;

        // Constructor que recibe una conexión
        public HouseDAO(MySqlConnection connection)
        {
            _connection = connection;
        }

        // Método para agregar una casa
        public void AddHouse(HouseDTO house)
        {
            var query = "INSERT INTO Houses (hous_name, hous_postalAddress, hous_postalCode, hous_nameStreet, hous_capacity, regi_id) VALUES (@hous_name, @hous_postalAddress, @hous_postalCode, @hous_nameStreet, @hous_capacity, @regi_id)";
            using (var command = new MySqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@hous_name", house.HouseName);
                command.Parameters.AddWithValue("@hous_postalAddress", house.PostalAddress);
                command.Parameters.AddWithValue("@hous_postalCode", house.PostalCode);
                command.Parameters.AddWithValue("@hous_nameStreet", house.NameStreet);
                command.Parameters.AddWithValue("@hous_capacity", house.Capacity);
                command.Parameters.AddWithValue("@regi_id", house.RegiId);

                try
                {
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al ejecutar la consulta en la base de datos.", ex);
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        // Método para obtener una casa por ID
        public HouseDTO GetHouse(int id)
        {
            var query = "SELECT hous_id, hous_name, hous_postalAddress, hous_postalCode, hous_nameStreet, hous_capacity, regi_id FROM Houses WHERE hous_id = @Id";
            using (var command = new MySqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new HouseDTO
                            {
                                HouseId = reader.GetInt32("hous_id"),
                                HouseName = reader.GetString("hous_name"),
                                PostalAddress = reader.GetString("hous_postalAddress"),
                                PostalCode = reader.GetInt32("hous_postalCode"),
                                NameStreet = reader.GetString("hous_nameStreet"),
                                Capacity = reader.GetInt32("hous_capacity"),
                                RegiId = reader.GetInt32("regi_id")
                            };
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al ejecutar la consulta en la base de datos.", ex);
                }
                finally
                {
                    _connection.Close();
                }
            }
            return null;
        }

        // Método para actualizar una casa
        public void UpdateHouse(HouseDTO house)
        {
            var query = "UPDATE Houses SET hous_name = @hous_name, hous_postalAddress = @hous_postalAddress, hous_postalCode = @hous_postalCode, hous_nameStreet = @hous_nameStreet, hous_capacity = @hous_capacity, regi_id = @regi_id WHERE hous_id = @hous_id";
            using (var command = new MySqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@hous_name", house.HouseName);
                command.Parameters.AddWithValue("@hous_postalAddress", house.PostalAddress);
                command.Parameters.AddWithValue("@hous_postalCode", house.PostalCode);
                command.Parameters.AddWithValue("@hous_nameStreet", house.NameStreet);
                command.Parameters.AddWithValue("@hous_capacity", house.Capacity);
                command.Parameters.AddWithValue("@regi_id", house.RegiId);
                command.Parameters.AddWithValue("@hous_id", house.HouseId);

                try
                {
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al ejecutar la consulta en la base de datos.", ex);
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        // Método para eliminar una casa
        public void DeleteHouse(int id)
        {
            var query = "DELETE FROM Houses WHERE hous_id = @Id";
            using (var command = new MySqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    _connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al ejecutar la consulta en la base de datos.", ex);
                }
                finally
                {
                    _connection.Close();
                }
            }
        }
    }
}
