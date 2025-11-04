using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grant resource.
/// </summary>
public class AwsS3controlAccessGrant : TerraformResource
{
    public AwsS3controlAccessGrant(string name) : base("aws_s3control_access_grant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_grant_arn");
        this.DeclareOutput("access_grant_id");
        this.DeclareOutput("grant_scope");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    public string? AccessGrantsLocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_grants_location_id")?.Value;
        set => this.WithProperty("access_grants_location_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    public string? Permission
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission")?.Value;
        set => this.WithProperty("permission", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The s3_prefix_type attribute.
    /// </summary>
    public string? S3PrefixType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_prefix_type")?.Value;
        set => this.WithProperty("s3_prefix_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The access_grant_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantArn => this["access_grant_arn"];

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantId => this["access_grant_id"];

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    public TerraformExpression GrantScope => this["grant_scope"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
