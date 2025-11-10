using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_connection resource.
/// </summary>
public class AwsDxHostedConnection : TerraformResource
{
    public AwsDxHostedConnection(string name) : base("aws_dx_hosted_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("aws_device");
        SetOutput("connection_region");
        SetOutput("has_logical_redundancy");
        SetOutput("jumbo_frame_capable");
        SetOutput("lag_id");
        SetOutput("loa_issue_time");
        SetOutput("location");
        SetOutput("partner_name");
        SetOutput("provider_name");
        SetOutput("region");
        SetOutput("state");
        SetOutput("bandwidth");
        SetOutput("connection_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("owner_account_id");
        SetOutput("vlan");
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    public required TerraformProperty<string> Bandwidth
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bandwidth");
        set => SetProperty("bandwidth", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    public required TerraformProperty<string> OwnerAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_account_id");
        set => SetProperty("owner_account_id", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformProperty<double> Vlan
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vlan");
        set => SetProperty("vlan", value);
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    public TerraformExpression ConnectionRegion => this["connection_region"];

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformExpression HasLogicalRedundancy => this["has_logical_redundancy"];

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformExpression JumboFrameCapable => this["jumbo_frame_capable"];

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    public TerraformExpression LagId => this["lag_id"];

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    public TerraformExpression LoaIssueTime => this["loa_issue_time"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformExpression PartnerName => this["partner_name"];

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformExpression ProviderName => this["provider_name"];

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
