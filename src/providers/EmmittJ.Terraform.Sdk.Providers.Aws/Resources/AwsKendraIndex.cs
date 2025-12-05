using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_units in AwsKendraIndex.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexCapacityUnitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_units";

    /// <summary>
    /// The query_capacity_units attribute.
    /// </summary>
    public TerraformValue<double> QueryCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("query_capacity_units") ?? CreateReference("query_capacity_units");
        set => SetArgument("query_capacity_units", value);
    }

    /// <summary>
    /// The storage_capacity_units attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("storage_capacity_units") ?? CreateReference("storage_capacity_units");
        set => SetArgument("storage_capacity_units", value);
    }

}


/// <summary>
/// Block type for document_metadata_configuration_updates in AwsKendraIndex.
/// Nesting mode: set
/// </summary>
public class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "document_metadata_configuration_updates";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Relevance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Relevance block(s) allowed")]
    public TerraformList<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockRelevanceBlock>? Relevance
    {
        get => GetArgument<TerraformList<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockRelevanceBlock>>("relevance");
        set => SetArgument("relevance", value);
    }

    /// <summary>
    /// Search block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Search block(s) allowed")]
    public TerraformList<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockSearchBlock>? Search
    {
        get => GetArgument<TerraformList<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockSearchBlock>>("search");
        set => SetArgument("search", value);
    }

}

/// <summary>
/// Block type for relevance in AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockRelevanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "relevance";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string> Duration
    {
        get => GetArgument<TerraformValue<string>>("duration") ?? CreateReference("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The freshness attribute.
    /// </summary>
    public TerraformValue<bool> Freshness
    {
        get => GetArgument<TerraformValue<bool>>("freshness") ?? CreateReference("freshness");
        set => SetArgument("freshness", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformValue<double> Importance
    {
        get => GetArgument<TerraformValue<double>>("importance") ?? CreateReference("importance");
        set => SetArgument("importance", value);
    }

    /// <summary>
    /// The rank_order attribute.
    /// </summary>
    public TerraformValue<string> RankOrder
    {
        get => GetArgument<TerraformValue<string>>("rank_order") ?? CreateReference("rank_order");
        set => SetArgument("rank_order", value);
    }

    /// <summary>
    /// The values_importance_map attribute.
    /// </summary>
    public TerraformMap<double> ValuesImportanceMap
    {
        get => GetArgument<TerraformMap<double>>("values_importance_map") ?? CreateReference("values_importance_map");
        set => SetArgument("values_importance_map", value);
    }

}

/// <summary>
/// Block type for search in AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlockSearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "search";

    /// <summary>
    /// The displayable attribute.
    /// </summary>
    public TerraformValue<bool> Displayable
    {
        get => GetArgument<TerraformValue<bool>>("displayable") ?? CreateReference("displayable");
        set => SetArgument("displayable", value);
    }

    /// <summary>
    /// The facetable attribute.
    /// </summary>
    public TerraformValue<bool> Facetable
    {
        get => GetArgument<TerraformValue<bool>>("facetable") ?? CreateReference("facetable");
        set => SetArgument("facetable", value);
    }

    /// <summary>
    /// The searchable attribute.
    /// </summary>
    public TerraformValue<bool> Searchable
    {
        get => GetArgument<TerraformValue<bool>>("searchable") ?? CreateReference("searchable");
        set => SetArgument("searchable", value);
    }

    /// <summary>
    /// The sortable attribute.
    /// </summary>
    public TerraformValue<bool> Sortable
    {
        get => GetArgument<TerraformValue<bool>>("sortable") ?? CreateReference("sortable");
        set => SetArgument("sortable", value);
    }

}


/// <summary>
/// Block type for server_side_encryption_configuration in AwsKendraIndex.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexServerSideEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption_configuration";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKendraIndex.
/// Nesting mode: single
/// </summary>
public class AwsKendraIndexTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_group_resolution_configuration in AwsKendraIndex.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserGroupResolutionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_group_resolution_configuration";

    /// <summary>
    /// The user_group_resolution_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserGroupResolutionMode is required")]
    public required TerraformValue<string> UserGroupResolutionMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_group_resolution_mode");
        set => SetArgument("user_group_resolution_mode", value);
    }

}


/// <summary>
/// Block type for user_token_configurations in AwsKendraIndex.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserTokenConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_token_configurations";

    /// <summary>
    /// JsonTokenTypeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonTokenTypeConfiguration block(s) allowed")]
    public TerraformList<AwsKendraIndexUserTokenConfigurationsBlockJsonTokenTypeConfigurationBlock>? JsonTokenTypeConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraIndexUserTokenConfigurationsBlockJsonTokenTypeConfigurationBlock>>("json_token_type_configuration");
        set => SetArgument("json_token_type_configuration", value);
    }

    /// <summary>
    /// JwtTokenTypeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtTokenTypeConfiguration block(s) allowed")]
    public TerraformList<AwsKendraIndexUserTokenConfigurationsBlockJwtTokenTypeConfigurationBlock>? JwtTokenTypeConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraIndexUserTokenConfigurationsBlockJwtTokenTypeConfigurationBlock>>("jwt_token_type_configuration");
        set => SetArgument("jwt_token_type_configuration", value);
    }

}

/// <summary>
/// Block type for json_token_type_configuration in AwsKendraIndexUserTokenConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserTokenConfigurationsBlockJsonTokenTypeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_token_type_configuration";

    /// <summary>
    /// The group_attribute_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupAttributeField is required")]
    public required TerraformValue<string> GroupAttributeField
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_attribute_field");
        set => SetArgument("group_attribute_field", value);
    }

    /// <summary>
    /// The user_name_attribute_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserNameAttributeField is required")]
    public required TerraformValue<string> UserNameAttributeField
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name_attribute_field");
        set => SetArgument("user_name_attribute_field", value);
    }

}

/// <summary>
/// Block type for jwt_token_type_configuration in AwsKendraIndexUserTokenConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserTokenConfigurationsBlockJwtTokenTypeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jwt_token_type_configuration";

    /// <summary>
    /// The claim_regex attribute.
    /// </summary>
    public TerraformValue<string>? ClaimRegex
    {
        get => GetArgument<TerraformValue<string>>("claim_regex");
        set => SetArgument("claim_regex", value);
    }

    /// <summary>
    /// The group_attribute_field attribute.
    /// </summary>
    public TerraformValue<string>? GroupAttributeField
    {
        get => GetArgument<TerraformValue<string>>("group_attribute_field");
        set => SetArgument("group_attribute_field", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The key_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyLocation is required")]
    public required TerraformValue<string> KeyLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_location");
        set => SetArgument("key_location", value);
    }

    /// <summary>
    /// The secrets_manager_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretsManagerArn
    {
        get => GetArgument<TerraformValue<string>>("secrets_manager_arn");
        set => SetArgument("secrets_manager_arn", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The user_name_attribute_field attribute.
    /// </summary>
    public TerraformValue<string>? UserNameAttributeField
    {
        get => GetArgument<TerraformValue<string>>("user_name_attribute_field");
        set => SetArgument("user_name_attribute_field", value);
    }

}


/// <summary>
/// Represents a aws_kendra_index Terraform resource.
/// Manages a aws_kendra_index resource.
/// </summary>
public partial class AwsKendraIndex(string name) : TerraformResource("aws_kendra_index", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string>? Edition
    {
        get => GetArgument<TerraformValue<string>>("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformValue<string>? UserContextPolicy
    {
        get => GetArgument<TerraformValue<string>>("user_context_policy");
        set => SetArgument("user_context_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => CreateReference("error_message");

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IndexStatistics
        => CreateReference("index_statistics");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => CreateReference("updated_at");

    /// <summary>
    /// CapacityUnits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityUnits block(s) allowed")]
    public TerraformList<AwsKendraIndexCapacityUnitsBlock>? CapacityUnits
    {
        get => GetArgument<TerraformList<AwsKendraIndexCapacityUnitsBlock>>("capacity_units");
        set => SetArgument("capacity_units", value);
    }

    /// <summary>
    /// DocumentMetadataConfigurationUpdates block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 DocumentMetadataConfigurationUpdates block(s) allowed")]
    public TerraformSet<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>? DocumentMetadataConfigurationUpdates
    {
        get => GetArgument<TerraformSet<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>>("document_metadata_configuration_updates");
        set => SetArgument("document_metadata_configuration_updates", value);
    }

    /// <summary>
    /// ServerSideEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsKendraIndexServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraIndexServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => SetArgument("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKendraIndexTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKendraIndexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserGroupResolutionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserGroupResolutionConfiguration block(s) allowed")]
    public TerraformList<AwsKendraIndexUserGroupResolutionConfigurationBlock>? UserGroupResolutionConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraIndexUserGroupResolutionConfigurationBlock>>("user_group_resolution_configuration");
        set => SetArgument("user_group_resolution_configuration", value);
    }

    /// <summary>
    /// UserTokenConfigurations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserTokenConfigurations block(s) allowed")]
    public TerraformList<AwsKendraIndexUserTokenConfigurationsBlock>? UserTokenConfigurations
    {
        get => GetArgument<TerraformList<AwsKendraIndexUserTokenConfigurationsBlock>>("user_token_configurations");
        set => SetArgument("user_token_configurations", value);
    }

}
