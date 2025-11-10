using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    public TerraformProperty<string>? GroupAttribute
    {
        get => GetProperty<TerraformProperty<string>>("group_attribute");
        set => WithProperty("group_attribute", value);
    }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    public TerraformProperty<string>? Metadata
    {
        get => GetProperty<TerraformProperty<string>>("metadata");
        set => WithProperty("metadata", value);
    }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    public TerraformProperty<double>? SessionTimeout
    {
        get => GetProperty<TerraformProperty<double>>("session_timeout");
        set => WithProperty("session_timeout", value);
    }

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    public TerraformProperty<string>? UserAttribute
    {
        get => GetProperty<TerraformProperty<string>>("user_attribute");
        set => WithProperty("user_attribute", value);
    }

}

/// <summary>
/// Retrieves information about a aws_opensearchserverless_security_config.
/// </summary>
public class AwsOpensearchserverlessSecurityConfigDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessSecurityConfigDataSource(string name) : base("aws_opensearchserverless_security_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("config_version");
        this.WithOutput("created_date");
        this.WithOutput("description");
        this.WithOutput("last_modified_date");
        this.WithOutput("type");
    }

    /// <summary>
    /// The unique identifier of the security configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for saml_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock>? SamlOptions
    {
        get => GetProperty<List<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock>>("saml_options");
        set => this.WithProperty("saml_options", value);
    }

    /// <summary>
    /// The version of the security configuration.
    /// </summary>
    public TerraformExpression ConfigVersion => this["config_version"];

    /// <summary>
    /// The date the configuration was created.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The description of the security configuration.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The date the configuration was last modified.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// The type of security configuration.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
