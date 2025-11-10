using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbNetworkPeeringConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// A peering connection between an ODB network and either another ODB network or a customer-owned VPC.
/// </summary>
public class AwsOdbNetworkPeeringConnection : TerraformResource
{
    public AwsOdbNetworkPeeringConnection(string name) : base("aws_odb_network_peering_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("id");
        this.WithOutput("odb_network_arn");
        this.WithOutput("odb_peering_connection_type");
        this.WithOutput("peer_network_arn");
        this.WithOutput("percent_progress");
        this.WithOutput("status");
        this.WithOutput("status_reason");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// Display name of the odb network peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Required field. The unique identifier of the ODB network that initiates the peering connection. A sample ID is odbpcx-abcdefgh12345678. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformProperty<string> OdbNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("odb_network_id");
        set => this.WithProperty("odb_network_id", value);
    }

    /// <summary>
    /// Required field. The unique identifier of the ODB peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetworkId is required")]
    public required TerraformProperty<string> PeerNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("peer_network_id");
        set => this.WithProperty("peer_network_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbNetworkPeeringConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsOdbNetworkPeeringConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    public TerraformExpression OdbNetworkArn => this["odb_network_arn"];

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    public TerraformExpression OdbPeeringConnectionType => this["odb_peering_connection_type"];

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    public TerraformExpression PeerNetworkArn => this["peer_network_arn"];

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The reason for the current status of the ODB peering connection..
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
