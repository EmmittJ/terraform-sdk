using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    public TerraformProperty<string>? GroupAttribute
    {
        set => SetProperty("group_attribute", value);
    }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformProperty<string> Metadata
    {
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    public TerraformProperty<double>? SessionTimeout
    {
        set => SetProperty("session_timeout", value);
    }

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    public TerraformProperty<string>? UserAttribute
    {
        set => SetProperty("user_attribute", value);
    }

}

/// <summary>
/// Manages a aws_opensearchserverless_security_config resource.
/// </summary>
public class AwsOpensearchserverlessSecurityConfig : TerraformResource
{
    public AwsOpensearchserverlessSecurityConfig(string name) : base("aws_opensearchserverless_security_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("config_version");
        SetOutput("id");
        SetOutput("description");
        SetOutput("name");
        SetOutput("region");
        SetOutput("type");
    }

    /// <summary>
    /// Description of the security configuration.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Type of configuration. Must be `saml`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>? SamlOptions
    {
        set => SetProperty("saml_options", value);
    }

    /// <summary>
    /// Version of the configuration.
    /// </summary>
    public TerraformExpression ConfigVersion => this["config_version"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
