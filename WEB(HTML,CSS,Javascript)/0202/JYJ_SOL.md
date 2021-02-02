# 문제풀이

## 3장 12번 문제보다 6장 12번 문제
```html
<!DOCTYPE html>
<html>
    <head>
		<meta charset="utf-8">
		<title></title>
	
        <style>
            * {
                margin: 0; padding: 0;
            }
            div {
                position: relative;
                overflow: hidden;
            }
            img {
                float: left;
                top: 0; left: 0;
                border-radius: 50%;
                margin: 5px;
            }
        </style>
    </head>
    <body>
        <div>
            <img src="http://placekitten.com/150/150" id="first">
            <p>Lorem ~~ </p>
        </div>
        <div>
            <img src="http://placekitten.com/110/110">
            <p>Lorem ~~ </p>
        </div>
    </body>
</html>
```

## 7장 2번 문제

### 7.2.1
```html
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	
	<style>
	div.container {
		width: 1080px;
		margin: 0 auto;
		margin-bottom: 8px;
		overflow: hidden;
    }

    div.left {
		float: left;
		width: 740px; height: 428px;
		background-color: red;
    }

    div.right {
      float: right;
      width: 332px; height: 428px;
      background-color: blue;
    }
	</style>
</head>
<body>
	<!-- 너비 1080px 컨테이너 -->
	<!-- 중앙정렬 -->
	<!-- 아래 margin : 8px -->
	<div class="container">
		<!-- div.left 왼쪽 붙이기  -->
		<!-- 너비 740px, 높이 428px -->
		<div class="left"></div>
		<!-- div.right 오른쪽 -->
		<!-- 너비 332px, 높이 428px -->
		<div class="right"></div>
	</div>	
</body>
</html>
```

### 7.2.2
```html
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	
	<style>
	div.container {
		width: 1080px;
		margin: 0 auto;
		margin-bottom: 8px;
		overflow: hidden;
    }
	
	ul.gnb {
      float: left;
      padding: 8px 0px; /* (위,아래) (왼쪽,오른쪽) */
      background-color: green;
    }
    ul.gnb li {
      list-style-type: none;
      float: left;
      padding-left: 16px;
    }
    ul.gnb li:first-child {
      padding-left: 0px;
    }

    ul.rank {
      float: right;
      padding: 8px 0px; /* (위,아래) (왼쪽,오른쪽) */
      background-color: yellow;
    }

    ul.rank li {
      list-style-type: none;
    }
	</style>
</head>
<body>
	<!-- div 컨테이너는 이전과 똑같이 적용 -->
	<div class="container">
		<!-- ul.gnb 왼쪽 붙이기 -->
		<!-- 위 아래 padding 8px -->
		<!-- 왼쪽 오른쪽 padding 0px -->
        <ul class="gnb">
			<!-- 내부 li 태그 none -->
			<!-- li 왼쪽 나란히, 가로 배열 -->
			<!-- li 왼쪽 padding 16px, 첫 번째는 padding 0px -->
            <li>메일</li>
            <li>카페</li>
            <li>블로그</li>
            <li>쇼핑</li>
            <li>사전</li>
            <li>뉴스</li>
            <li>증권</li>
            <li>부동산</li>
            <li>지도</li>
        </ul>

        <ul class="rank">
            <li>실시간 검색 순위</li>
        </ul>
    </div>
</body>
</html>
```

### 7.2.3
```html
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
	
	<style>
	div.container {
		width: 1080px;
		margin: 0 auto;
		margin-bottom: 8px;
		overflow: hidden;
    }
	div.left {
		float: left;
		width: 740px; height: 428px;
		background-color: red;
    }
    div.right {
      float: right;
      width: 332px; height: 428px;
      background-color: blue;
    }
	
	ul.gnb {
		float: left;
		padding: 8px 0px; /* (위,아래) (왼쪽,오른쪽) */
		background-color: green;
    }
    ul.gnb li {
		list-style-type: none;
		float: left;
		padding-left: 16px;
    }
    ul.gnb li:first-child {
		padding-left: 0px;
    }

    ul.rank {
		float: right;
		padding: 8px 0px; /* (위,아래) (왼쪽,오른쪽) */
		background-color: yellow;
    }

    ul.rank li {
		list-style-type: none;
    }
	
	div.footer {
		height: 80px;
		background-color: yellow;
	}
	</style>
</head>
<body>
	<div class="container">
    <div class="container">
        <ul class="gnb">
	        <li>메일</li>
            <li>카페</li>
            <li>블로그</li>
            <li>쇼핑</li>
            <li>사전</li>
            <li>뉴스</li>
            <li>증권</li>
            <li>부동산</li>
            <li>지도</li>
        </ul>

        <ul class="rank">
            <li>실시간 검색 순위</li>
        </ul>
    </div>
	
	<div class="container">
		<div class="left"></div>
		<div class="right"></div>
	</div>	
	<div class="container">
		<div class="left"></div>
		<div class="right"></div>
	</div>
	<div class="container">
		<div class="footer"></div>
	</div>
</body>
</html>
```

## 11장 11번 문제
```html
<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<title></title>
	
	<style>
		* {
			margin: 0px;
			padding: 0px;
		}
		
		p {
			margin: 10px 0px;
		}
		
		.drawer {
			position: fixed;
			width: 100%;
			text-align: center;
			color: white;
			background-color: red;
		}
		.drawer h1 {
			height: 50px;
			line-height: 50px;
		}
		.drawer-menu {
			display: none;
		}
		
		.content {
			padding: 10px;
			padding-top: 60px;
		}
	</style>
	<script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
	<script>
	var flag = false;
	$(document).ready(function(){
		$("body").click(function() {
			flag = !flag;
			
			if(flag) {
				$(".drawer-menu").css({
					display: "block"
				}).animate({
					height: "200px"
				}, 1000);
			} else {
				$(".drawer-menu").animate({
					height: "0px"
				}, 1000);
			
			}
		});
	});
	</script>
</head>

<body>
	<div class="drawer">
		<h1>Logo</h1>
		<div class="drawer-menu">
			<p> Esse partiatur</p>
		</div>
	</div>
	<div class="content">
		<h1>Lorem ipsum</h1>
		<p>sfjklafjqwklfjwqklfjqwklfwjqklfqwjfklqwjfklqwjklfq</p>
		<p>fwklfjqwklfjqw klfqjkljqwkl ffjklwjfklqwjklw fqwjkl</p>
		<p>afjklafj ffklwjqwl wfqjklqwj klfqjklqwjfklq</p>
		<p>djwkl wfjqklfjqwkl fwjkqlfjqklwf jfakljklfjklfaj</p>
	</div>
</body>

</html>
```

