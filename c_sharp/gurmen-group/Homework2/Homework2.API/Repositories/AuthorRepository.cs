using Dapper;
using Homework2.API.Dtos.Author;
using Homework2.API.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Homework2.API.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbConnection _connection;

        public AuthorRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<bool> Any(int id)
        {
            var query = $"SELECT EXISTS ( SELECT 1 FROM author WHERE author.id = {id})";
            return await _connection.ExecuteScalarAsync<bool>(query);
        }

        public async Task<bool> Delete(int id)
        {
           var command = $"delete from author where author.id ={id}";
           return await _connection.ExecuteAsync(command) > 0;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var query = "select * from author";
            return (await _connection.QueryAsync<Author>(query)).AsList();
        }

        public async Task<Author> GetById(int id)
        {
            var query = $"select * from author where author.id = {id}";
            return await _connection.QuerySingleOrDefaultAsync<Author>(query);
        }

        public async Task<int> Save(Author model)
        {
            var command = $"insert into author (name) values (@Name) returning id";
            return await _connection.ExecuteScalarAsync<int>(command, model);
        }

        public async Task<bool> Update(Author model)
        {
            var command = "CALL update_author (@Name, @Id)";
            return await _connection.ExecuteAsync(command, model) > 0;
        }

        public async Task<IEnumerable<AuthorBook>> GetAuthorByIdWithBook(int id)
        {
            var query = $"SELECT * FROM func_full_book({id})";
            return (await _connection.QueryAsync<AuthorBook>(query)).AsList();
        }
    }
}
