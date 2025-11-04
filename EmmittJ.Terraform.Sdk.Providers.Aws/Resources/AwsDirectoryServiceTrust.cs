using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_trust resource.
/// </summary>
public class AwsDirectoryServiceTrust : TerraformResource
{
    public AwsDirectoryServiceTrust(string name) : base("aws_directory_service_trust", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date_time");
        this.DeclareOutput("id");
        this.DeclareOutput("last_updated_date_time");
        this.DeclareOutput("state_last_updated_date_time");
        this.DeclareOutput("trust_state");
        this.DeclareOutput("trust_state_reason");
    }

    /// <summary>
    /// The conditional_forwarder_ip_addrs attribute.
    /// </summary>
    public HashSet<string>? ConditionalForwarderIpAddrs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("conditional_forwarder_ip_addrs")?.Value;
        set => this.WithProperty("conditional_forwarder_ip_addrs", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    public bool? DeleteAssociatedConditionalForwarder
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_associated_conditional_forwarder")?.Value;
        set => this.WithProperty("delete_associated_conditional_forwarder", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    public string? RemoteDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_domain_name")?.Value;
        set => this.WithProperty("remote_domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    public string? SelectiveAuth
    {
        get => GetProperty<TerraformLiteralProperty<string>>("selective_auth")?.Value;
        set => this.WithProperty("selective_auth", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    public string? TrustDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_direction")?.Value;
        set => this.WithProperty("trust_direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    public string? TrustPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_password")?.Value;
        set => this.WithProperty("trust_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    public string? TrustType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_type")?.Value;
        set => this.WithProperty("trust_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    public TerraformExpression CreatedDateTime => this["created_date_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDateTime => this["last_updated_date_time"];

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression StateLastUpdatedDateTime => this["state_last_updated_date_time"];

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    public TerraformExpression TrustState => this["trust_state"];

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    public TerraformExpression TrustStateReason => this["trust_state_reason"];

}
