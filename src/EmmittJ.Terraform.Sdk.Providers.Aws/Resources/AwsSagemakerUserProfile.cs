using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_user_profile resource.
/// </summary>
public class AwsSagemakerUserProfile : TerraformResource
{
    public AwsSagemakerUserProfile(string name) : base("aws_sagemaker_user_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("home_efs_file_system_uid");
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
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SingleSignOnUserIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("single_sign_on_user_identifier");
        set => this.WithProperty("single_sign_on_user_identifier", value);
    }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    public TerraformProperty<string>? SingleSignOnUserValue
    {
        get => GetProperty<TerraformProperty<string>>("single_sign_on_user_value");
        set => this.WithProperty("single_sign_on_user_value", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
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

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    public TerraformExpression HomeEfsFileSystemUid => this["home_efs_file_system_uid"];

}
