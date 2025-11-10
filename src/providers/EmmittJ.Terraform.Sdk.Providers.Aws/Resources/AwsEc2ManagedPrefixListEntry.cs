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
        SetOutput("cidr");
        SetOutput("description");
        SetOutput("id");
        SetOutput("prefix_list_id");
        SetOutput("region");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformProperty<string> Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr");
        set => SetProperty("cidr", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The prefix_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListId is required")]
    public required TerraformProperty<string> PrefixListId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix_list_id");
        set => SetProperty("prefix_list_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
