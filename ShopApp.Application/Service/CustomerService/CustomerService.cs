using ShopApp.Application.Interface.Customers;
using ShopApp.Domain.Base;
using ShopApp.Domain.Interface.Customers;
using ShopApp.Domain.Models.Customers;

namespace ShopApp.Application.Service.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomerService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }
        public async Task<OperationResult<CustomersCreateModel>> CreateCategoriaAsync(CustomersCreateModel model)
        {
            return await _customersRepository.CreateCategoriaAsync(model);
        }

        public async  Task<OperationResult<CustomersDeleteModel>> DeleteCategoriaByIdAsync(int id, int delete_user)
        {
            return await _customersRepository.DeleteCategoriaByIdAsync(id, delete_user);
        }

        public async Task<OperationResult<List<CustomersGetModel>>> GetAllCategoriaAsync()
        {
            return await _customersRepository.GetAllCategoriaAsync();
        }

        public async Task<OperationResult<CustomersGetModel>> GetCategoriaByIdAsync(int id)
        {
            return await _customersRepository.GetCategoriaByIdAsync(id);
        }

        public async Task<OperationResult<CustomersUpdateModel>> UpdateCategoria(CustomersUpdateModel model)
        {
            return await _customersRepository.UpdateCategoria(model);
        }
    }
}
