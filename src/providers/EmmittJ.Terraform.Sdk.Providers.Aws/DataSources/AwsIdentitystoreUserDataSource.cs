using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in AwsIdentitystoreUserDataSource.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alternate_identifier";

    /// <summary>
    /// ExternalId block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalId block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlockExternalIdBlock>? ExternalId
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlockExternalIdBlock>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// UniqueAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UniqueAttribute block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlockUniqueAttributeBlock>? UniqueAttribute
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlockUniqueAttributeBlock>>("unique_attribute");
        set => SetArgument("unique_attribute", value);
    }

}

/// <summary>
/// Block type for external_id in AwsIdentitystoreUserDataSourceAlternateIdentifierBlock.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlockExternalIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_id";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

}

/// <summary>
/// Block type for unique_attribute in AwsIdentitystoreUserDataSourceAlternateIdentifierBlock.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlockUniqueAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unique_attribute";

    /// <summary>
    /// The attribute_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributePath is required")]
    public required TerraformValue<string> AttributePath
    {
        get => GetRequiredArgument<TerraformValue<string>>("attribute_path");
        set => SetArgument("attribute_path", value);
    }

    /// <summary>
    /// The attribute_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeValue is required")]
    public required TerraformValue<string> AttributeValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("attribute_value");
        set => SetArgument("attribute_value", value);
    }

}


/// <summary>
/// Represents a aws_identitystore_user Terraform data source.
/// Retrieves information about a aws_identitystore_user.
/// </summary>
public partial class AwsIdentitystoreUserDataSource(string name) : TerraformDataSource("aws_identitystore_user", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => GetArgument<TerraformValue<string>>("user_id") ?? CreateReference("user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Addresses
        => CreateReference("addresses");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The emails attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Emails
        => CreateReference("emails");

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalIds
        => CreateReference("external_ids");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string> Locale
        => CreateReference("locale");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Name
        => CreateReference("name");

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformValue<string> Nickname
        => CreateReference("nickname");

    /// <summary>
    /// The phone_numbers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhoneNumbers
        => CreateReference("phone_numbers");

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformValue<string> PreferredLanguage
        => CreateReference("preferred_language");

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformValue<string> ProfileUrl
        => CreateReference("profile_url");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
        => CreateReference("timezone");

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string> Title
        => CreateReference("title");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
        => CreateReference("user_name");

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformValue<string> UserType
        => CreateReference("user_type");

    /// <summary>
    /// AlternateIdentifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>? AlternateIdentifier
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>>("alternate_identifier");
        set => SetArgument("alternate_identifier", value);
    }

}
