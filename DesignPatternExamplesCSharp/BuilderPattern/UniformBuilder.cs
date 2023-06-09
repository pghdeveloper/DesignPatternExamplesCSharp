using BuilderPattern.Interfaces;

namespace BuilderPattern;

public class UniformBuilder : IUniformBuilder {  
    Uniform uniform = new Uniform();  
    public void SetId() {  
        uniform.Id = 1;  
    }  
    public void SetPrice() {  
        uniform.Price = 100m;  
    }  
    public void SetType() {  
        uniform.Type = "GI";
    }  
    public void SetCreatedDate() {  
        uniform.CreatedDate = new DateTimeOffset(2008, 5, 1, 0, 0, 0,
            new TimeSpan(1, 0, 0));
    }
    public Uniform GetUniform() {  
        return uniform;  
    }  
}