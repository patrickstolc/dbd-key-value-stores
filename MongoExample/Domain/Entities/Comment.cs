using MongoExample.Domain.ValueObjects;

namespace MongoExample.Core.Models;

public class Comment 
{
    public CommentId Id { get; set; }
    public string Content { get; set; }
    public string UserId { get; set; }
    public string UserName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
} 