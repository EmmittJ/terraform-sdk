using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDatabaseMigrationServicePrivateConnection.
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServicePrivateConnectionTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_peering_config in GoogleDatabaseMigrationServicePrivateConnection.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServicePrivateConnectionVpcPeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_peering_config";

    /// <summary>
    /// A free subnet for peering. (CIDR of /29)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    public required TerraformValue<string> Subnet
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Fully qualified name of the VPC that Database Migration Service will peer to.
    /// Format: projects/{project}/global/{networks}/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcName is required")]
    public required TerraformValue<string> VpcName
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_name");
        set => SetArgument("vpc_name", value);
    }

}


/// <summary>
/// Represents a google_database_migration_service_private_connection Terraform resource.
/// Manages a google_database_migration_service_private_connection resource.
/// </summary>
public partial class GoogleDatabaseMigrationServicePrivateConnection(string name) : TerraformResource("google_database_migration_service_private_connection", name)
{
    /// <summary>
    /// If set to true, will skip validations.
    /// </summary>
    public TerraformValue<bool>? CreateWithoutValidation
    {
        get => GetArgument<TerraformValue<bool>>("create_without_validation");
        set => SetArgument("create_without_validation", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
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
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the location this private connection is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The private connectivity identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnectionId is required")]
    public required TerraformValue<string> PrivateConnectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_connection_id");
        set => SetArgument("private_connection_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The PrivateConnection error in case of failure.
    /// </summary>
    public TerraformList<TerraformMap<object>> Error
        => CreateReference("error");

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// State of the PrivateConnection.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDatabaseMigrationServicePrivateConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDatabaseMigrationServicePrivateConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcPeeringConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcPeeringConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConfig block(s) allowed")]
    public required TerraformList<GoogleDatabaseMigrationServicePrivateConnectionVpcPeeringConfigBlock> VpcPeeringConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDatabaseMigrationServicePrivateConnectionVpcPeeringConfigBlock>>("vpc_peering_config");
        set => SetArgument("vpc_peering_config", value);
    }

}
