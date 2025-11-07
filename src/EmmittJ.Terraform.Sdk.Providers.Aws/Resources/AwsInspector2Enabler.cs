using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_inspector2_enabler resource.
/// </summary>
public class AwsInspector2Enabler : TerraformResource
{
    public AwsInspector2Enabler(string name) : base("aws_inspector2_enabler", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AccountIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("account_ids");
        set => this.WithProperty("account_ids", value);
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
    /// The resource_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ResourceTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

}
