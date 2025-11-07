using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appflow_connector_profile resource.
/// </summary>
public class AwsAppflowConnectorProfile : TerraformResource
{
    public AwsAppflowConnectorProfile(string name) : base("aws_appflow_connector_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("credentials_arn");
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
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
    public TerraformProperty<string>? ConnectorType
    {
        get => GetProperty<TerraformProperty<string>>("connector_type");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformExpression CredentialsArn => this["credentials_arn"];

}
