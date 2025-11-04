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
    public string? ConnectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_mode")?.Value;
        set => this.WithProperty("connection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    public string? ConnectorLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connector_label")?.Value;
        set => this.WithProperty("connector_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public string? ConnectorType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connector_type")?.Value;
        set => this.WithProperty("connector_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_arn attribute.
    /// </summary>
    public string? KmsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_arn")?.Value;
        set => this.WithProperty("kms_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
