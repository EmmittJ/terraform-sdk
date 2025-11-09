using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appfabric_app_authorization resource.
/// </summary>
public class AwsAppfabricAppAuthorization : TerraformResource
{
    public AwsAppfabricAppAuthorization(string name) : base("aws_appfabric_app_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auth_url");
        this.DeclareOutput("created_at");
        this.DeclareOutput("id");
        this.DeclareOutput("persona");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    public TerraformProperty<string>? App
    {
        get => GetProperty<TerraformProperty<string>>("app");
        set => this.WithProperty("app", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AppBundleArn
    {
        get => GetProperty<TerraformProperty<string>>("app_bundle_arn");
        set => this.WithProperty("app_bundle_arn", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthType
    {
        get => GetProperty<TerraformProperty<string>>("auth_type");
        set => this.WithProperty("auth_type", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth_url attribute.
    /// </summary>
    public TerraformExpression AuthUrl => this["auth_url"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The persona attribute.
    /// </summary>
    public TerraformExpression Persona => this["persona"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
