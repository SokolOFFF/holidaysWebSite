using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

public class ResponseRepository
{
    private static ResponseRepository repository = new ResponseRepository();
    private List<testGuestResponse> responses = new List<testGuestResponse>();

    public static ResponseRepository GetRepository()
    {
        return repository;
    }


    public IEnumerable<testGuestResponse> GetAllResponses()
    {
        return responses;
    }
    public void AddResponse(testGuestResponse response)
    {
        responses.Add(response);
    }
}
