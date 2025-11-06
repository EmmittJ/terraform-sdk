using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_identitystore_user resource.
/// </summary>
public class AwsIdentitystoreUser : TerraformResource
{
    public AwsIdentitystoreUser(string name) : base("aws_identitystore_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("external_ids");
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_store_id attribute.
    /// </summary>
    public string? IdentityStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_store_id")?.Value;
        set => this.WithProperty("identity_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public string? Locale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locale")?.Value;
        set => this.WithProperty("locale", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public string? Nickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nickname")?.Value;
        set => this.WithProperty("nickname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public string? PreferredLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_language")?.Value;
        set => this.WithProperty("preferred_language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public string? ProfileUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_url")?.Value;
        set => this.WithProperty("profile_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The timezone attribute.
    /// </summary>
    public string? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone")?.Value;
        set => this.WithProperty("timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title")?.Value;
        set => this.WithProperty("title", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public string? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type")?.Value;
        set => this.WithProperty("user_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformExpression ExternalIds => this["external_ids"];

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
