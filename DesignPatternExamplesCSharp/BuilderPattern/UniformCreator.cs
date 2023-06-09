using BuilderPattern.Interfaces;

namespace BuilderPattern;

public class UniformCreator {  
    private IUniformBuilder _uniformBuilder;  
    public UniformCreator(IUniformBuilder uniformBuilder) {  
        _uniformBuilder = uniformBuilder;  
    }  
    public void CreateUniform() {  
        _uniformBuilder.SetId();  
        _uniformBuilder.SetPrice();  
        _uniformBuilder.SetType();  
        _uniformBuilder.SetCreatedDate();
    }  
    public Uniform GetUniform() {  
        return _uniformBuilder.GetUniform();  
    }  
}  