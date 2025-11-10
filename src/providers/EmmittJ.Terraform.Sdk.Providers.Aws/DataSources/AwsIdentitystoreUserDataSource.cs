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
        SetOutput("addresses");
        SetOutput("display_name");
        SetOutput("emails");
        SetOutput("external_ids");
        SetOutput("locale");
        SetOutput("name");
        SetOutput("nickname");
        SetOutput("phone_numbers");
        SetOutput("preferred_language");
        SetOutput("profile_url");
        SetOutput("timezone");
        SetOutput("title");
        SetOutput("user_name");
        SetOutput("user_type");
        SetOutput("id");
        SetOutput("identity_store_id");
        SetOutput("region");
        SetOutput("user_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_store_id");
        set => SetProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    public List<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>? AlternateIdentifier
    {
        set => SetProperty("alternate_identifier", value);
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
