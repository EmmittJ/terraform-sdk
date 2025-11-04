using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53domains_registered_domain resource.
/// </summary>
public class AwsRoute53domainsRegisteredDomain : TerraformResource
{
    public AwsRoute53domainsRegisteredDomain(string name) : base("aws_route53domains_registered_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("abuse_contact_email");
        this.DeclareOutput("abuse_contact_phone");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("registrar_name");
        this.DeclareOutput("registrar_url");
        this.DeclareOutput("reseller");
        this.DeclareOutput("status_list");
        this.DeclareOutput("updated_date");
        this.DeclareOutput("whois_server");
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public bool? AdminPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_privacy")?.Value;
        set => this.WithProperty("admin_privacy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public bool? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_renew")?.Value;
        set => this.WithProperty("auto_renew", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public bool? BillingPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("billing_privacy")?.Value;
        set => this.WithProperty("billing_privacy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The registrant_privacy attribute.
    /// </summary>
    public bool? RegistrantPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registrant_privacy")?.Value;
        set => this.WithProperty("registrant_privacy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public bool? TechPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tech_privacy")?.Value;
        set => this.WithProperty("tech_privacy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public bool? TransferLock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transfer_lock")?.Value;
        set => this.WithProperty("transfer_lock", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    public TerraformExpression AbuseContactEmail => this["abuse_contact_email"];

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    public TerraformExpression AbuseContactPhone => this["abuse_contact_phone"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformExpression RegistrarName => this["registrar_name"];

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformExpression RegistrarUrl => this["registrar_url"];

    /// <summary>
    /// The reseller attribute.
    /// </summary>
    public TerraformExpression Reseller => this["reseller"];

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformExpression StatusList => this["status_list"];

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformExpression UpdatedDate => this["updated_date"];

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformExpression WhoisServer => this["whois_server"];

}
