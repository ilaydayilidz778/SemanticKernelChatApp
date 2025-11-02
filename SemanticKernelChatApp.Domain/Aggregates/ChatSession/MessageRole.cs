namespace SemanticKernelChatApp.Domain.Aggregates.ChatSession;

/// <summary>
/// AI sohbetindeki mesajın rolünü belirtir
/// </summary>
public enum MessageRole
{
    /// <summary>
    /// Sistem mesajı (AI'ın davranışını belirleyen talimatlar)
    /// Örnek: "Sen yardımsever bir asistansın"
    /// </summary>
    System = 0,
    
    /// <summary>
    /// Kullanıcı mesajı (insan tarafından gönderilen)
    /// Örnek: "Merhaba, nasılsın?"
    /// </summary>
    User = 1,
    
    /// <summary>
    /// Asistan mesajı (AI tarafından üretilen cevap)
    /// Örnek: "İyiyim, teşekkür ederim!"
    /// </summary>
    Assistant = 2
}