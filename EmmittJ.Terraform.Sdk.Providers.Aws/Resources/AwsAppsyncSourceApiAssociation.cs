using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_source_api_association resource.
/// </summary>
public class AwsAppsyncSourceApiAssociation : TerraformResource
{
    public AwsAppsyncSourceApiAssociation(string name) : base("aws_appsync_source_api_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The merged_api_arn attribute.
    /// </summary>
    public string? MergedApiArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("merged_api_arn")?.Value;
        set => this.WithProperty("merged_api_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The merged_api_id attribute.
    /// </summary>
    public string? MergedApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("merged_api_id")?.Value;
        set => this.WithProperty("merged_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_api_arn attribute.
    /// </summary>
    public string? SourceApiArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_api_arn")?.Value;
        set => this.WithProperty("source_api_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_api_association_config attribute.
    /// </summary>
    public List<object>? SourceApiAssociationConfig
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("source_api_association_config")?.Value;
        set => this.WithProperty("source_api_association_config", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public string? SourceApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_api_id")?.Value;
        set => this.WithProperty("source_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
