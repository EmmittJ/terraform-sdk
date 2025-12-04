using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in AwsIdentitystoreGroupDataSource.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alternate_identifier";

    /// <summary>
    /// ExternalId block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalId block(s) allowed")]
    public TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockExternalIdBlock>? ExternalId
    {
        get => GetArgument<TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockExternalIdBlock>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// UniqueAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UniqueAttribute block(s) allowed")]
    public TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockUniqueAttributeBlock>? UniqueAttribute
    {
        get => GetArgument<TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockUniqueAttributeBlock>>("unique_attribute");
        set => SetArgument("unique_attribute", value);
    }

}

/// <summary>
/// Block type for external_id in AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockExternalIdBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

}

/// <summary>
/// Block type for unique_attribute in AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreGroupDataSourceAlternateIdentifierBlockUniqueAttributeBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("attribute_path");
        set => SetArgument("attribute_path", value);
    }

    /// <summary>
    /// The attribute_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeValue is required")]
    public required TerraformValue<string> AttributeValue
    {
        get => GetArgument<TerraformValue<string>>("attribute_value");
        set => SetArgument("attribute_value", value);
    }

}


/// <summary>
/// Represents a aws_identitystore_group Terraform data source.
/// Retrieves information about a aws_identitystore_group.
/// </summary>
public partial class AwsIdentitystoreGroupDataSource(string name) : TerraformDataSource("aws_identitystore_group", name)
{
    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string>? GroupId
    {
        get => GetArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => GetArgument<TerraformValue<string>>("identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalIds
        => AsReference("external_ids");

    /// <summary>
    /// AlternateIdentifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    public TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock>? AlternateIdentifier
    {
        get => GetArgument<TerraformList<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock>>("alternate_identifier");
        set => SetArgument("alternate_identifier", value);
    }

}
