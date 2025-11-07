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
    public TerraformProperty<bool>? AdminPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("admin_privacy");
        set => this.WithProperty("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? BillingPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("billing_privacy");
        set => this.WithProperty("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? RegistrantPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("registrant_privacy");
        set => this.WithProperty("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? TechPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("tech_privacy");
        set => this.WithProperty("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformProperty<bool>? TransferLock
    {
        get => GetProperty<TerraformProperty<bool>>("transfer_lock");
        set => this.WithProperty("transfer_lock", value);
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
