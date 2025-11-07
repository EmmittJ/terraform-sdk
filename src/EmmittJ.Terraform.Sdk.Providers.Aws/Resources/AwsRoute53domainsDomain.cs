using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53domains_domain resource.
/// </summary>
public class AwsRoute53domainsDomain : TerraformResource
{
    public AwsRoute53domainsDomain(string name) : base("aws_route53domains_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("abuse_contact_email");
        this.DeclareOutput("abuse_contact_phone");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("registrar_name");
        this.DeclareOutput("registrar_url");
        this.DeclareOutput("status_list");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("updated_date");
        this.DeclareOutput("whois_server");
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AdminPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_privacy");
        set => this.WithProperty("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// The billing_contact attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? BillingContact
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("billing_contact");
        set => this.WithProperty("billing_contact", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BillingPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("billing_privacy");
        set => this.WithProperty("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The duration_in_years attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DurationInYears
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_in_years");
        set => this.WithProperty("duration_in_years", value);
    }

    /// <summary>
    /// The name_server attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? NameServer
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("name_server");
        set => this.WithProperty("name_server", value);
    }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RegistrantPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registrant_privacy");
        set => this.WithProperty("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TechPrivacy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tech_privacy");
        set => this.WithProperty("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TransferLock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transfer_lock");
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
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformExpression RegistrarName => this["registrar_name"];

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformExpression RegistrarUrl => this["registrar_url"];

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformExpression StatusList => this["status_list"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformExpression UpdatedDate => this["updated_date"];

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformExpression WhoisServer => this["whois_server"];

}
