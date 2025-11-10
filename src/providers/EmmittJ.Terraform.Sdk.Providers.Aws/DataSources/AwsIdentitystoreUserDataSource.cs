using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlock : TerraformBlock
{
}

/// <summary>
/// Retrieves information about a aws_identitystore_user.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIdentitystoreUserDataSource : TerraformDataSource
{
    public AwsIdentitystoreUserDataSource(string name) : base("aws_identitystore_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("addresses");
        this.WithOutput("display_name");
        this.WithOutput("emails");
        this.WithOutput("external_ids");
        this.WithOutput("locale");
        this.WithOutput("name");
        this.WithOutput("nickname");
        this.WithOutput("phone_numbers");
        this.WithOutput("preferred_language");
        this.WithOutput("profile_url");
        this.WithOutput("timezone");
        this.WithOutput("title");
        this.WithOutput("user_name");
        this.WithOutput("user_type");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    public List<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>? AlternateIdentifier
    {
        get => GetProperty<List<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>>("alternate_identifier");
        set => this.WithProperty("alternate_identifier", value);
    }

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    public TerraformExpression Addresses => this["addresses"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The emails attribute.
    /// </summary>
    public TerraformExpression Emails => this["emails"];

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformExpression ExternalIds => this["external_ids"];

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformExpression Locale => this["locale"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformExpression Nickname => this["nickname"];

    /// <summary>
    /// The phone_numbers attribute.
    /// </summary>
    public TerraformExpression PhoneNumbers => this["phone_numbers"];

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformExpression PreferredLanguage => this["preferred_language"];

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformExpression ProfileUrl => this["profile_url"];

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformExpression Timezone => this["timezone"];

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformExpression Title => this["title"];

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformExpression UserName => this["user_name"];

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformExpression UserType => this["user_type"];

}
