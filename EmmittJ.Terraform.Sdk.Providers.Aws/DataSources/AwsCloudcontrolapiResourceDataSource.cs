using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudcontrolapi_resource.
/// </summary>
public class AwsCloudcontrolapiResourceDataSource : TerraformDataSource
{
    public AwsCloudcontrolapiResourceDataSource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("properties");
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
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
