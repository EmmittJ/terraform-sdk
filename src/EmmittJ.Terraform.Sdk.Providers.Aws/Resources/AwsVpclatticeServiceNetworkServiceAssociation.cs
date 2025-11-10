using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_vpclattice_service_network_service_association resource.
/// </summary>
public class AwsVpclatticeServiceNetworkServiceAssociation : TerraformResource
{
    public AwsVpclatticeServiceNetworkServiceAssociation(string name) : base("aws_vpclattice_service_network_service_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_by");
        this.DeclareOutput("custom_domain_name");
        this.DeclareOutput("dns_entry");
        this.DeclareOutput("status");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceIdentifier is required")]
    public required TerraformProperty<string> ServiceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("service_identifier");
        set => this.WithProperty("service_identifier", value);
    }

    /// <summary>
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    public required TerraformProperty<string> ServiceNetworkIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("service_network_identifier");
        set => this.WithProperty("service_network_identifier", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpclatticeServiceNetworkServiceAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    public TerraformExpression CustomDomainName => this["custom_domain_name"];

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformExpression DnsEntry => this["dns_entry"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
