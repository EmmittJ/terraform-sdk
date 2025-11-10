using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connector_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_appflow_connector_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppflowConnectorProfile : TerraformResource
{
    public AwsAppflowConnectorProfile(string name) : base("aws_appflow_connector_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("credentials_arn");
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionMode is required")]
    public required TerraformProperty<string> ConnectionMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorLabel
    {
        get => GetProperty<TerraformProperty<string>>("connector_label");
        set => this.WithProperty("connector_label", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connector_type");
        set => this.WithProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_arn");
        set => this.WithProperty("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for connector_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileConfig block(s) allowed")]
    public List<AwsAppflowConnectorProfileConnectorProfileConfigBlock>? ConnectorProfileConfig
    {
        get => GetProperty<List<AwsAppflowConnectorProfileConnectorProfileConfigBlock>>("connector_profile_config");
        set => this.WithProperty("connector_profile_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformExpression CredentialsArn => this["credentials_arn"];

}
