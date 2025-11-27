using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_hosted_connection Terraform resource.
/// Manages a aws_dx_hosted_connection resource.
/// </summary>
public partial class AwsDxHostedConnection(string name) : TerraformResource("aws_dx_hosted_connection", name)
{
    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    public required TerraformValue<string> Bandwidth
    {
        get => new TerraformReference<string>(this, "bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    public required TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
        set => SetArgument("owner_account_id", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformValue<double> Vlan
    {
        get => new TerraformReference<double>(this, "vlan");
        set => SetArgument("vlan", value);
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
    {
        get => new TerraformReference<string>(this, "aws_device");
    }

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    public TerraformValue<string> ConnectionRegion
    {
        get => new TerraformReference<string>(this, "connection_region");
    }

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformValue<string> HasLogicalRedundancy
    {
        get => new TerraformReference<string>(this, "has_logical_redundancy");
    }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
    {
        get => new TerraformReference<bool>(this, "jumbo_frame_capable");
    }

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    public TerraformValue<string> LagId
    {
        get => new TerraformReference<string>(this, "lag_id");
    }

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    public TerraformValue<string> LoaIssueTime
    {
        get => new TerraformReference<string>(this, "loa_issue_time");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformValue<string> PartnerName
    {
        get => new TerraformReference<string>(this, "partner_name");
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}
