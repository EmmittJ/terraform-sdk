using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_app resource.
/// </summary>
public class AwsSagemakerApp : TerraformResource
{
    public AwsSagemakerApp(string name) : base("aws_sagemaker_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    public TerraformProperty<string>? AppName
    {
        get => GetProperty<TerraformProperty<string>>("app_name");
        set => this.WithProperty("app_name", value);
    }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    public TerraformProperty<string>? AppType
    {
        get => GetProperty<TerraformProperty<string>>("app_type");
        set => this.WithProperty("app_type", value);
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformProperty<string>? DomainId
    {
        get => GetProperty<TerraformProperty<string>>("domain_id");
        set => this.WithProperty("domain_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    public TerraformProperty<string>? SpaceName
    {
        get => GetProperty<TerraformProperty<string>>("space_name");
        set => this.WithProperty("space_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserProfileName
    {
        get => GetProperty<TerraformProperty<string>>("user_profile_name");
        set => this.WithProperty("user_profile_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
