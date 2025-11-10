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
        SetOutput("arn");
        SetOutput("credentials_arn");
        SetOutput("connection_mode");
        SetOutput("connector_label");
        SetOutput("connector_type");
        SetOutput("id");
        SetOutput("kms_arn");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionMode is required")]
    public required TerraformProperty<string> ConnectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_mode");
        set => SetProperty("connection_mode", value);
    }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    public TerraformProperty<string> ConnectorLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connector_label");
        set => SetProperty("connector_label", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connector_type");
        set => SetProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_arn");
        set => SetProperty("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
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
    /// Block for connector_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileConfig block(s) allowed")]
    public List<AwsAppflowConnectorProfileConnectorProfileConfigBlock>? ConnectorProfileConfig
    {
        set => SetProperty("connector_profile_config", value);
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
