using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip_domain_name resource.
/// </summary>
public class AwsEipDomainName : TerraformResource
{
    public AwsEipDomainName(string name) : base("aws_eip_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("ptr_record");
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationId
    {
        get => GetProperty<TerraformProperty<string>>("allocation_id");
        set => this.WithProperty("allocation_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformExpression PtrRecord => this["ptr_record"];

}
