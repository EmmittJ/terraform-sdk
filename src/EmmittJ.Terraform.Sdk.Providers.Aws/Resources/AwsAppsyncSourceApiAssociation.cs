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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The merged_api_arn attribute.
    /// </summary>
    public TerraformProperty<string>? MergedApiArn
    {
        get => GetProperty<TerraformProperty<string>>("merged_api_arn");
        set => this.WithProperty("merged_api_arn", value);
    }

    /// <summary>
    /// The merged_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? MergedApiId
    {
        get => GetProperty<TerraformProperty<string>>("merged_api_id");
        set => this.WithProperty("merged_api_id", value);
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
    /// The source_api_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceApiArn
    {
        get => GetProperty<TerraformProperty<string>>("source_api_arn");
        set => this.WithProperty("source_api_arn", value);
    }

    /// <summary>
    /// The source_api_association_config attribute.
    /// </summary>
    public TerraformProperty<List<object>>? SourceApiAssociationConfig
    {
        get => GetProperty<TerraformProperty<List<object>>>("source_api_association_config");
        set => this.WithProperty("source_api_association_config", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceApiId
    {
        get => GetProperty<TerraformProperty<string>>("source_api_id");
        set => this.WithProperty("source_api_id", value);
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
