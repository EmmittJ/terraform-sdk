using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxHostedPrivateVirtualInterfaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_dx_hosted_private_virtual_interface resource.
/// </summary>
public class AwsDxHostedPrivateVirtualInterface : TerraformResource
{
    public AwsDxHostedPrivateVirtualInterface(string name) : base("aws_dx_hosted_private_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("amazon_side_asn");
        SetOutput("arn");
        SetOutput("aws_device");
        SetOutput("jumbo_frame_capable");
        SetOutput("address_family");
        SetOutput("amazon_address");
        SetOutput("bgp_asn");
        SetOutput("bgp_auth_key");
        SetOutput("connection_id");
        SetOutput("customer_address");
        SetOutput("id");
        SetOutput("mtu");
        SetOutput("name");
        SetOutput("owner_account_id");
        SetOutput("region");
        SetOutput("vlan");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformProperty<string> AddressFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_family");
        set => SetProperty("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformProperty<string> AmazonAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("amazon_address");
        set => SetProperty("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    public required TerraformProperty<double> BgpAsn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("bgp_asn");
        set => SetProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformProperty<string> BgpAuthKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_auth_key");
        set => SetProperty("bgp_auth_key", value);
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
    /// The customer_address attribute.
    /// </summary>
    public TerraformProperty<string> CustomerAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_address");
        set => SetProperty("customer_address", value);
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
    /// The mtu attribute.
    /// </summary>
    public TerraformProperty<double> Mtu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("mtu");
        set => SetProperty("mtu", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDxHostedPrivateVirtualInterfaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformExpression AmazonSideAsn => this["amazon_side_asn"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformExpression JumboFrameCapable => this["jumbo_frame_capable"];

}
