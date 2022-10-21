using ScraperHelper.Models;

namespace ScraperHelper.Services;

public class RequestsService
{
    public List<Response> GetNeededRequests(Request req)
    {
        var responses = new List<Response>();
        var neededFields = new List<NeededField>();
        foreach (var cookie in req.Cookies)
        {
            neededFields.Add(new NeededField()
            {
                Key = cookie.Key,
                Value = cookie.Value,
                FieldType = FieldType.Cookie
            });
        }

        foreach (var header in req.Headers)
        {
            neededFields.Add(new NeededField()
            {
                Key = header.Key,
                Value = header.Value,
                FieldType = FieldType.Header
            });
        }

        if (req.FormData != null)
            foreach (var header in req.FormData)
            {
                neededFields.Add(new NeededField()
                {
                    Key = header.Key,
                    Value = header.Value,
                    FieldType = FieldType.FormData
                });
            }

        foreach (var response in Global.State.AllResponses)
        {
            if (response.Request.Number == req.Number) continue;
            foreach (var neededField in neededFields)
            {
                var t = LocateNeededField(neededField, response);
                if (t)
                    responses.Add(response);
            }
        }

        return responses;
    }

    public bool LocateNeededField(NeededField field, Response response)
    {
        foreach (var c in response.Cookies)
        {
            if (c.Value.Contains(field.Value))
            {
                return true;
            }
        }

        foreach (var c in response.Headers)
        {
            if (c.Value.Contains(field.Value))
            {
                return true;
            }
        }

        if (response.Content.Contains(field.Value))
            return true;
        return false;
    }
}