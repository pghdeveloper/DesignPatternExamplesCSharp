namespace BuilderPattern.Interfaces;

public interface IUniformBuilder
{
    void SetId();  
    void SetPrice();  
    void SetType();  
    void SetCreatedDate();
    Uniform GetUniform();
}