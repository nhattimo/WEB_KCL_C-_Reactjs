import Intro from "../child/intro";

const intro =[

]

 const IntroAbout = () => {
    const image ="https://fpt.com/-/media/project/fpt-corporation/fpt/common/fpt/our-business/technology/cong-nghe_home.jpg"
  return(
    
          <>
            <div className=" my-5">
            <div className="br  bg-color-2">
        <div  className="container bg-color-2">
          <div className="about-us">
            <div className="row">
              <div className="block-our-business-title">
                <h2 className="font-weight-light">Hệ Sinh Thái KCL</h2>
                <span className="block-our-business-desc-title ">
                Xây dựng
                Hoạt động tư vấn thiết kế.
                Hoạt động tư vấn quản lý xây dựng.
                Thi công công trình.
                <br />
                2. Công nghệ thông tin
                Tư vấn CNTT
                Hạ tầng mạng
                Thiết bị CNTT
                <br />
                3. Giải pháp thiết bị thông minh
                Màn hình tích hợp thông minh UNV
                Giải pháp chiếu sáng thông minh, smart home

                </span>
              </div>
            </div>
          </div>
        </div>
              <div className="bg-1">
                     <div className="container mt-5">
                      <div className="row mb-4">
              <Intro img={image} title="Viễn thông" subtitle=""
              link="/blog/this-is-a-post-title"
              />
                       <Intro img={image} title="Viễn thông"  subtitle="Chúng tôi không ngừng đầu tư, triển khai và tích hợp ngày càng nhiều các dịch vụ giá trị gia tăng trên công nghệ đường truyền Internet và kiến tạo hệ sinh thái truyền thông số."
                       link="/blog/this-is-a-post-title"
                       ></Intro>
                      </div>
                      <div className="row mb-4">
                      <Intro img={image} title="Viễn thông" subtitle=" FPT là đối tác chiến lược quan trọng về tư vấn, đào tạo, triển khai chuyển đổi số của các tập đoàn, tổ chức hàng đầu trên thế giới và tại Việt Nam trong nhiều lĩnh vực."
              link="/blog/this-is-a-post-title"
              />
                       <Intro img={image} title="Viễn thông"  subtitle="Chúng tôi không ngừng đầu tư, triển khai và tích hợp ngày càng nhiều các dịch vụ giá trị gia tăng trên công nghệ đường truyền Internet và kiến tạo hệ sinh thái truyền thông số."
                       link="/blog/this-is-a-post-title"
                       ></Intro>
              </div>
                    </div>
                  </div>
            </div>
            </div>
          </>
  )
  }
  
  export default IntroAbout;