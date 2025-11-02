namespace SemanticKernelChatApp.Domain.Aggregates.ChatSession;

public class ChatSession
{
    /// <summary>
    /// Bu session'daki tüm mesajlar
    /// Private - dışardan doğrudan eklenemez/silinemez
    /// </summary>
    private readonly List<Message> _messages = new();
    
    /// <summary>
    /// Bu session'ın sahibi olan kullanıcı
    /// </summary>
    public UserId UserId { get; private set; }
    
    /// <summary>
    /// Session başlığı (örn: "Python Öğrenme", "Proje Planı")
    /// </summary>
    public string Title { get; private set; }
    
    /// <summary>
    /// Kullanılan AI modeli (GPT-4, Claude, Gemini, vb.)
    /// </summary>
    public ModelType ModelType { get; private set; }
    
    /// <summary>
    /// Session oluşturulma tarihi
    /// </summary>
    public DateTime CreatedAt { get; private set; }
    
    /// <summary>
    /// Son güncellenme tarihi
    /// </summary>
    public DateTime? UpdatedAt { get; private set; }
    
    /// <summary>
    /// Session silinmiş mi? (Soft delete)
    /// </summary>
    public bool IsDeleted { get; private set; }
    
    /// <summary>
    /// Bu session'daki toplam token sayısı (context yönetimi için)
    /// </summary>
    public int TotalTokenCount { get; private set; }
    
    // CONSTRUCTORS
    public ChatSession()
    {
        
    }
}