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
        get => GetArgument<TerraformValue<string>>("bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    public required TerraformValue<string> OwnerAccountId
    {
        get => GetArgument<TerraformValue<string>>("owner_account_id");
        set => SetArgument("owner_account_id", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformValue<double> Vlan
    {
        get => GetArgument<TerraformValue<double>>("vlan");
        set => SetArgument("vlan", value);
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
        => AsReference("aws_device");

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    public TerraformValue<string> ConnectionRegion
        => AsReference("connection_region");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformValue<string> HasLogicalRedundancy
        => AsReference("has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
        => AsReference("jumbo_frame_capable");

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    public TerraformValue<string> LagId
        => AsReference("lag_id");

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    public TerraformValue<string> LoaIssueTime
        => AsReference("loa_issue_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformValue<string> PartnerName
        => AsReference("partner_name");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
        => AsReference("provider_name");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
        => AsReference("region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

}
