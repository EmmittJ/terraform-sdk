using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("config_version");
        this.DeclareOutput("created_date");
        this.DeclareOutput("description");
        this.DeclareOutput("last_modified_date");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The unique identifier of the security configuration.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
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
