namespace EveOfMidnight.Api.Models;

public sealed record Error
{
    public Error(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentNullException(nameof(message));
        }

        Message = message;
    }

    public Error(string message, int statusCode)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentNullException(nameof(message));
        }

        StatusCode = statusCode;

        Message = message;
    }

    public Error(string message, int statusCode, IEnumerable<Link> links)
    {
        StatusCode = statusCode;
        Message = message;
        Links = links.ToList();
    }

    /// <value>
    /// The returned status code
    /// </value>
    public int StatusCode { get; }

    /// <value>
    /// The message body for the error in a human friendly form
    /// </value>
    public string Message { get; }

    /// <value>
    /// Links containing relevant steps to the error
    /// </value>
    public List<Link> Links { get; }

    public override string ToString()
    {
        return Message;
    }
}

