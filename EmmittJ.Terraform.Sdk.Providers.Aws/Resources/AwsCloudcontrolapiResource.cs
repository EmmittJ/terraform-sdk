using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudcontrolapi_resource resource.
/// </summary>
public class AwsCloudcontrolapiResource : TerraformResource
{
    public AwsCloudcontrolapiResource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("properties");
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    public string? DesiredState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desired_state")?.Value;
        set => this.WithProperty("desired_state", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public string? Schema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema")?.Value;
        set => this.WithProperty("schema", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public string? TypeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_name")?.Value;
        set => this.WithProperty("type_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    public string? TypeVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_version_id")?.Value;
        set => this.WithProperty("type_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

}
