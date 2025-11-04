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
    public string? DomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_id")?.Value;
        set => this.WithProperty("domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    public string? SingleSignOnUserIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("single_sign_on_user_identifier")?.Value;
        set => this.WithProperty("single_sign_on_user_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    public string? SingleSignOnUserValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("single_sign_on_user_value")?.Value;
        set => this.WithProperty("single_sign_on_user_value", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_profile_name attribute.
    /// </summary>
    public string? UserProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_profile_name")?.Value;
        set => this.WithProperty("user_profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
