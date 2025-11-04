using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_tag_option_resource_association resource.
/// </summary>
public class AwsServicecatalogTagOptionResourceAssociation : TerraformResource
{
    public AwsServicecatalogTagOptionResourceAssociation(string name) : base("aws_servicecatalog_tag_option_resource_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_arn");
        this.DeclareOutput("resource_created_time");
        this.DeclareOutput("resource_description");
        this.DeclareOutput("resource_name");
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
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_option_id attribute.
    /// </summary>
    public string? TagOptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_option_id")?.Value;
        set => this.WithProperty("tag_option_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

    /// <summary>
    /// The resource_created_time attribute.
    /// </summary>
    public TerraformExpression ResourceCreatedTime => this["resource_created_time"];

    /// <summary>
    /// The resource_description attribute.
    /// </summary>
    public TerraformExpression ResourceDescription => this["resource_description"];

    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    public TerraformExpression ResourceName => this["resource_name"];

}
