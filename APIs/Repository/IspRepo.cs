namespace APIs.Repository
{
    public interface IspRepo
    {

        Task<int> spAsync(int? Id, string FristName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);

    }
}
