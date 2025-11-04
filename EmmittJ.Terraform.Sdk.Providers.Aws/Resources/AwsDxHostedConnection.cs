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
        this.DeclareOutput("aws_device");
        this.DeclareOutput("connection_region");
        this.DeclareOutput("has_logical_redundancy");
        this.DeclareOutput("jumbo_frame_capable");
        this.DeclareOutput("lag_id");
        this.DeclareOutput("loa_issue_time");
        this.DeclareOutput("location");
        this.DeclareOutput("partner_name");
        this.DeclareOutput("provider_name");
        this.DeclareOutput("region");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    public string? Bandwidth
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bandwidth")?.Value;
        set => this.WithProperty("bandwidth", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public string? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id")?.Value;
        set => this.WithProperty("connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public string? OwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_account_id")?.Value;
        set => this.WithProperty("owner_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    public double? Vlan
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vlan")?.Value;
        set => this.WithProperty("vlan", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
