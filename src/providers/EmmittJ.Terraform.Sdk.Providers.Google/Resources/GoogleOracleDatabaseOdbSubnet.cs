using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleOracleDatabaseOdbSubnet.
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseOdbSubnetTimeoutsBlock : TerraformBlock
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
/// Represents a google_oracle_database_odb_subnet Terraform resource.
/// Manages a google_oracle_database_odb_subnet resource.
/// </summary>
public partial class GoogleOracleDatabaseOdbSubnet(string name) : TerraformResource("google_oracle_database_odb_subnet", name)
{
    /// <summary>
    /// The CIDR range of the subnet.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrRange is required")]
    public required TerraformValue<string> CidrRange
    {
        get => GetArgument<TerraformValue<string>>("cidr_range");
        set => SetArgument("cidr_range", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// Labels or tags associated with the resource.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the OdbSubnet to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnetId is required")]
    public required TerraformValue<string> OdbSubnetId
    {
        get => GetArgument<TerraformValue<string>>("odb_subnet_id");
        set => SetArgument("odb_subnet_id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Odbnetwork is required")]
    public required TerraformValue<string> Odbnetwork
    {
        get => GetArgument<TerraformValue<string>>("odbnetwork");
        set => SetArgument("odbnetwork", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Purpose of the subnet.
    /// Possible values:
    /// CLIENT_SUBNET
    /// BACKUP_SUBNET
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Purpose is required")]
    public required TerraformValue<string> Purpose
    {
        get => GetArgument<TerraformValue<string>>("purpose");
        set => SetArgument("purpose", value);
    }

    /// <summary>
    /// The date and time that the OdbNetwork was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. The name of the OdbSubnet resource in the following format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// State of the ODB Subnet.
    /// Possible values:
    /// PROVISIONING
    /// AVAILABLE
    /// TERMINATING
    /// FAILED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOracleDatabaseOdbSubnetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOracleDatabaseOdbSubnetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
