using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeNatAddress.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeNatAddressTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_nat_address Terraform resource.
/// Manages a google_apigee_nat_address resource.
/// </summary>
public partial class GoogleApigeeNatAddress(string name) : TerraformResource("google_apigee_nat_address", name)
{
    /// <summary>
    /// Flag that specifies whether the reserved NAT address should be activate.
    /// </summary>
    public TerraformValue<bool>? Activate
    {
        get => new TerraformReference<bool>(this, "activate");
        set => SetArgument("activate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The Apigee instance associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/instances/{{instance_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Resource ID of the NAT address.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The allocated NAT IP address.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// State of the NAT IP address.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeNatAddressTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeNatAddressTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
