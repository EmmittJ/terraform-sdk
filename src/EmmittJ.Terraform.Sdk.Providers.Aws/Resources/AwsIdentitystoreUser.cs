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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The identity_store_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityStoreId
    {
        get => GetProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string>? Locale
    {
        get => GetProperty<TerraformProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformProperty<string>? Nickname
    {
        get => GetProperty<TerraformProperty<string>>("nickname");
        set => this.WithProperty("nickname", value);
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredLanguage
    {
        get => GetProperty<TerraformProperty<string>>("preferred_language");
        set => this.WithProperty("preferred_language", value);
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileUrl
    {
        get => GetProperty<TerraformProperty<string>>("profile_url");
        set => this.WithProperty("profile_url", value);
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
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserType
    {
        get => GetProperty<TerraformProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
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
