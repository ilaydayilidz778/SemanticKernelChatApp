namespace SemanticKernelChatApp.Domain.Aggregates.ChatSession;

public class Message : Entity<MessageId>
{
    /// <summary>
    /// Bu mesajın ait olduğu chat session'ın ID'si
    /// </summary>
    public ChatSessionId ChatSessionId { get; private set; }
    
    /// <summary>
    /// Mesajın içeriği (ValueObject olarak)
    /// </summary>
    public MessageContent Content { get; private set; }
    
    /// <summary>
    /// Mesajın rolü (System, User, Assistant)
    /// </summary>
    public MessageRole MessageRole { get; private set; } 
    
    /// <summary>
    /// Mesajın oluşturulma zamanı
    /// </summary>
    public DateTime Timestamp { get; private set; }
    
    /// <summary>
    /// Bu mesajın tahmini token sayısı (AI context yönetimi için)
    /// </summary>
    public int TokenCount { get; private set; }

    private Message()
    {
        
    }
    
}