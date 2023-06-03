namespace Courseproject.Common.Dtos;
public interface IAddressService
{
    Task<int> CreateAddressAsync(AddressCreate addressCreate);
    Task UpdateAddressAsync(AddressUpdate addressUpdate);
    Task DeleteAddressAsync(AddressDelete addressDelete);
    Task<AddressGet> GetAddressAsync(int id);
    Task<List<AddressGet>> GetAddressesAsync();
}