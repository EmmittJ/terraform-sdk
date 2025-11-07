using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_managed_prefix_list_entry resource.
/// </summary>
public class AwsEc2ManagedPrefixListEntry : TerraformResource
{
    public AwsEc2ManagedPrefixListEntry(string name) : base("aws_ec2_managed_prefix_list_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrefixListId
    {
        get => GetProperty<TerraformProperty<string>>("prefix_list_id");
        set => this.WithProperty("prefix_list_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
