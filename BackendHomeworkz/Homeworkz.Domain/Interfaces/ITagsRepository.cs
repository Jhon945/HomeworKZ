using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface ITagsRepository
    {

        Task<List<Tags>> GetAllAsync();

        Task<Tags?> GetByIdAsync(int it);

        Task<Tags> CreateAsync(Tags tag);

        Task<Tags> UpdateAsync(Tags tag);

        Task<bool> DeleteAsync(Tags tag);
    }
}
